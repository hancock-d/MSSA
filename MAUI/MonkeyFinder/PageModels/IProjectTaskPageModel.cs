using CommunityToolkit.Mvvm.Input;
using MonkeyFinder.Models;

namespace MonkeyFinder.PageModels
{
    public interface IProjectTaskPageModel
    {
        IAsyncRelayCommand<ProjectTask> NavigateToTaskCommand { get; }
        bool IsBusy { get; }
    }
}