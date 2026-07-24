using CommunityToolkit.Mvvm.Input;
using MauiClientApp.Models;

namespace MauiClientApp.PageModels
{
    public interface IProjectTaskPageModel
    {
        IAsyncRelayCommand<ProjectTask> NavigateToTaskCommand { get; }
        bool IsBusy { get; }
    }
}