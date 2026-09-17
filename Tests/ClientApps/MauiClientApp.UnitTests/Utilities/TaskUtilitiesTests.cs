using MauiClientApp.Services;
using MauiClientApp.Utilities;

namespace MauiClientApp.UnitTests.Utilities;

[TestClass]
public sealed class TaskUtilitiesTests
{
    private sealed class ErrorHandlerSpy : IErrorHandler
    {
        private readonly TaskCompletionSource _handled = new(TaskCreationOptions.RunContinuationsAsynchronously);

        public Exception? LastError { get; private set; }

        public Task Handled => _handled.Task;

        public void HandleError(Exception ex)
        {
            LastError = ex;
            _handled.TrySetResult();
        }
    }

    [TestMethod]
    public async Task FireAndForgetSafeAsync_WhenTaskCompletes_RunsTaskToCompletion()
    {
        var completed = new TaskCompletionSource(TaskCreationOptions.RunContinuationsAsynchronously);

        async Task RunAsync()
        {
            await Task.Yield();
            completed.TrySetResult();
        }

        RunAsync().FireAndForgetSafeAsync();

        await completed.Task;
    }

    [TestMethod]
    public async Task FireAndForgetSafeAsync_WhenTaskFaults_PassesExceptionToHandler()
    {
        var expected = new InvalidOperationException("boom");
        var spy = new ErrorHandlerSpy();

        Task FaultedAsync() => Task.FromException(expected);

        FaultedAsync().FireAndForgetSafeAsync(spy);

        await spy.Handled;
        Assert.AreSame(expected, spy.LastError);
    }

    [TestMethod]
    public async Task FireAndForgetSafeAsync_WhenTaskFaultsWithoutHandler_DoesNotThrow()
    {
        var faulted = Task.FromException(new InvalidOperationException("boom"));

        // The exception must be swallowed inside the async void body;
        // if it escapes, the test host would crash.
        faulted.FireAndForgetSafeAsync();

        await Task.Delay(100);
    }
}
