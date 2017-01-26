using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlannerFormBL;
using PlannerFormBL.DataModel;


namespace PlannerForm
{
    class MainPresenter
    {
        private readonly IMainForm _view;
        private readonly IPlannerBl _manager;
        private readonly IMessageService _messageService;

        private List<PlanTask> PlanList { get; set; }

        private const string PATH = "C:/Users/oleg/Documents/Visual Studio 2015/Projects/ FilePlanner.txt";


        public MainPresenter(IMainForm view, IPlannerBl manager, IMessageService messageService)
        {
            _view = view;
            _manager = manager;
            _messageService = messageService;

            _view.Exit += _view_Exit;
            _view.SaveTaskClick += _view_SaveTaskClick;
            _view.TaskDeleteClick += _view_TaskDeleteClick;
            _view.TaskAddClick += _view_TaskAddClick;
            _view.TaskShowCklick += _view_TaskShowCklick;
        }

        private void _view_Exit(object sender, EventArgs e)
        {
            _messageService.ShowMessage("Good Bye!");
        }

        private void _view_SaveTaskClick(object sender, EventArgs e)
        {
            _manager.SavePlans();
        }

        private void _view_TaskDeleteClick(object sender, EventArgs e)
        {
           
            var plans = new PlanTask();
            _manager.DeletEvent(plans);
        }

        private void _view_TaskAddClick(object sender, EventArgs e)
        {
                var plans = new PlanTask();
                _manager.AddEvent(plans);
        }

        private void _view_TaskShowCklick(object sender, EventArgs e)
        {

            var plans = _manager.GetPlans();

            foreach (var plan in plans)
            {
                _view.TaskContent=Convert.ToString(plan);
            }

        }
    }
}
