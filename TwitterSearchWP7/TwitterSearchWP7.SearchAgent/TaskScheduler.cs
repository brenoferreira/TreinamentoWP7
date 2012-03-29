using Microsoft.Phone.Scheduler;
using TwitterSearchWP7.Twitter;
using System.Linq;

namespace TwitterSearchWP7.SearchAgent
{
    public class TaskScheduler : ScheduledTaskAgent
    {
        /// <summary>
        /// Agent that runs a scheduled task
        /// </summary>
        /// <param name="task">
        /// The invoked task
        /// </param>
        /// <remarks>
        /// This method is called when a periodic or resource intensive task is invoked
        /// </remarks>
        protected override void OnInvoke(ScheduledTask task)
        {
            //TODO: Add code to perform your task in background

            var searcher = new Searcher();

            searcher.Search(task.Description, (tweets) =>
                {
                    Microsoft.Phone.Shell.ShellToast toast = new Microsoft.Phone.Shell.ShellToast();
                    toast.Title = "New Tweets";
                    toast.Content = string.Format("{0} new tweets for {1}", tweets.Count(), task.Description);

                    toast.Show();

                    NotifyComplete();
                });
        }


        /// <summary>
        /// Called when the agent request is getting cancelled
        /// </summary>
        protected override void OnCancel()
        {
            base.OnCancel();

            //TODO: This Task is cancelled, do necessary clean up 
        }
    }
}
