using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlannerForm
{
    public interface IMainForm
    {      
        string TaskContent { get; set; }
        event EventHandler TaskShowCklick;
        event EventHandler TaskAddClick;
        event EventHandler TaskDeleteClick;
        event EventHandler SaveTaskClick;
        event EventHandler Exit;

    }
    public partial class MainForm : Form, IMainForm
    {
        public MainForm()
        {
            InitializeComponent();
            butExit.Click += ButExit_Click;
            butSaveTask.Click += ButSaveTask_Click;
            butDeleteTask.Click += ButDeleteTask_Click;
            butAddTask.Click += ButAddTask_Click;
            butShowTask.Click += ButShowTask_Click;

        }
        #region Проброс Событий
        private void ButExit_Click(object sender, EventArgs e)
        {
            if (Exit != null) Exit(this, EventArgs.Empty);
        }

        private void ButSaveTask_Click(object sender, EventArgs e)
        {
            if (SaveTaskClick != null) SaveTaskClick(this, EventArgs.Empty);
        }

        private void ButDeleteTask_Click(object sender, EventArgs e)
        {
            if (TaskDeleteClick != null) TaskDeleteClick(this, EventArgs.Empty);
        }

        private void ButAddTask_Click(object sender, EventArgs e)
        {
            if (TaskAddClick != null) TaskAddClick(this, EventArgs.Empty);
        }

        private void ButShowTask_Click(object sender, EventArgs e)
        {
            if (TaskShowCklick != null) TaskShowCklick(this, EventArgs.Empty);
        }
        #endregion
        #region Реализация IMainForm
        public string TaskContent
        {
            get { return BoxTaskContent.Text; }
            set { BoxTaskContent.Text=value; }
        }

        

        public event EventHandler TaskShowCklick;
        public event EventHandler TaskAddClick;
        public event EventHandler TaskDeleteClick;
        public event EventHandler SaveTaskClick;
        public event EventHandler Exit;
        #endregion
    }

}
