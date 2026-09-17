using MauiClientApp.Services;

namespace MauiClientApp.Utilities
{
    /// <summary>
    /// Task Utilities.
    /// </summary>
    public static class TaskUtilities
    {
        /// <summary>
        /// Fire and Forget Safe Async.
        /// </summary>
        /// <param name="task">Task to Fire and Forget.</param>
        /// <param name="handler">Error Handler.</param>
        public static async void FireAndForgetSafeAsync(this Task task, IErrorHandler? handler = null)
        {
            try
            {
                await task;
            }
            catch (OperationCanceledException)
            {
                // Task cancellation is expected in some flows; do not treat as an error.
            }
            catch (Exception ex) when (ex is not OperationCanceledException)
            {
                handler?.HandleError(ex);
            }
        }
    }
}