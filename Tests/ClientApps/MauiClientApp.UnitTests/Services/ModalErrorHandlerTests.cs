using System.Reflection;
using MauiClientApp.Services;

namespace MauiClientApp.UnitTests.Services;

[TestClass]
public sealed class ModalErrorHandlerTests
{
    private static SemaphoreSlim? GetSemaphore(ModalErrorHandler handler) =>
        (SemaphoreSlim?)typeof(ModalErrorHandler)
            .GetField("_semaphore", BindingFlags.Instance | BindingFlags.NonPublic)
            ?.GetValue(handler);

    [TestMethod]
    public void HandleError_WhenShellIsNotAvailable_DoesNotThrow()
    {
        var handler = new ModalErrorHandler();

        handler.HandleError(new InvalidOperationException("boom"));
    }

    [TestMethod]
    public async Task HandleError_ReleasesSemaphoreAfterHandling()
    {
        var handler = new ModalErrorHandler();
        var semaphore = GetSemaphore(handler);

        Assert.IsNotNull(semaphore);

        handler.HandleError(new InvalidOperationException("boom"));

        // DisplayAlertAsync is fire-and-forget; without an initialized Shell it
        // should finish quickly and release the semaphore again.
        var released = await semaphore.WaitAsync(TimeSpan.FromSeconds(5));
        Assert.IsTrue(released, "Semaphore was not released after handling the error.");
    }

    [TestMethod]
    public async Task HandleError_CanBeCalledMultipleTimes_DoesNotDeadlock()
    {
        var handler = new ModalErrorHandler();
        var semaphore = GetSemaphore(handler);

        Assert.IsNotNull(semaphore);

        handler.HandleError(new InvalidOperationException("first"));
        handler.HandleError(new InvalidOperationException("second"));

        await Task.Delay(200);
        Assert.AreEqual(1, semaphore.CurrentCount, "Semaphore leaked a slot; concurrent alerts would deadlock.");
    }
}
