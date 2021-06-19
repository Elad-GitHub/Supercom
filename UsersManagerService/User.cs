//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Timers;

namespace UsersManagerService
{
    
    public partial class User
    {
        public int ID { get; set; }
        public string Name { get; set; }

        private Timer Timer;

        public User(int id, string name, int interval)
        {
            ID = id;
            Name = name;
            Timer = new Timer();
            Timer.Interval = interval;
            Timer.Elapsed += OnTimedEvent;
            Timer.AutoReset = true;
            Timer.Enabled = true;
        }

        private void OnTimedEvent(Object source, System.Timers.ElapsedEventArgs e)
        {
            SendEmail();
        }

        private void SendEmail()
        {
            //sends an email
        }
    }
}
