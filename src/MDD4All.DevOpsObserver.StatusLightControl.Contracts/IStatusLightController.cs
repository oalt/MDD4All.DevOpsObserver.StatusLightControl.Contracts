using MDD4All.DevOpsObserver.DataModels;
using System.Threading.Tasks;

namespace MDD4All.DevOpsObserver.StatusLightControl.Contracts
{
    public interface IStatusLightController
    {
        bool IsOn { get; }

        DevOpsStatus CurrentStatus { get; }

        Task TurnLightOnAsync();

        Task TurnLightOffAsync();

        Task SetStatusLightAsync(DevOpsStatus devOpsStatus);

        Task ActivateAlertAsync();
    }
}
