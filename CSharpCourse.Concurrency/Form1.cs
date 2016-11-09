using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpCourse.Concurrency
{
    public delegate void EventCallReturnString(string callbackString);
            
    public partial class Form1 : Form
    {
        //this.Invoke(new EventCallReturnString(ChangeLabel), TimeSpan.FromTicks(System.Environment.TickCount - _ticks).TotalSeconds.ToString());

        private long _ticks;
        private List<Drink> _drinks = new List<Drink>();

        private EventCallReturnString _callReturn;

        public Form1()
        {            
            InitializeComponent();

            _callReturn = new EventCallReturnString(ChangeLabel);            
        }

        private void ChangeLabel(string labelValue)
        {
            labelTime.Text = labelValue;
        }

        private async void NoThreadClick(object sender, EventArgs e)
        {
            _ticks = System.Environment.TickCount;
            _drinks = _drinks.Select(x => new Drink() { Name = x.Name, Price = x.Price + 0.1 }).ToList();
            labelTime.Text = TimeSpan.FromTicks(System.Environment.TickCount - _ticks).TotalSeconds.ToString();
        }

        private void ThreadClick(object sender, EventArgs e)
        {
            new Thread(() =>
            {
                _ticks = System.Environment.TickCount;
                _drinks = _drinks.Select(x => new Drink() { Name = x.Name, Price = x.Price + 0.1 }).ToList();                
                this.Invoke(new EventCallReturnString(ChangeLabel), TimeSpan.FromTicks(System.Environment.TickCount - _ticks).TotalSeconds.ToString());
                //labelTime.Text = TimeSpan.FromTicks(System.Environment.TickCount - _ticks).TotalSeconds.ToString();
            }).Start();
        }

        private void AsyncClick(object sender, EventArgs e)
        {
            new Task(() =>
            {
                _ticks = System.Environment.TickCount;
                _drinks = _drinks.Select(x => new Drink() { Name = x.Name, Price = x.Price + 0.1 }).ToList();
                this.Invoke(new EventCallReturnString(ChangeLabel), TimeSpan.FromTicks(System.Environment.TickCount - _ticks).TotalSeconds.ToString());
                //labelTime.Text = TimeSpan.FromTicks(System.Environment.TickCount - _ticks).TotalSeconds.ToString();                                
            }).Start();
        }

        private void ParallelClick(object sender, EventArgs e)
        {
            new Task(() =>
            {
                _ticks = System.Environment.TickCount;
                //_drinks = _drinks.AsParallel().Select(x => new Drink() { Name = x.Name, Price = x.Price + 0.1 }).ToList();
                _drinks = _drinks.AsParallel().Select(x => new Drink() { Name = x.Name, Price = x.Price + Math.Sqrt(0.1) }).ToList();
                this.Invoke(new EventCallReturnString(ChangeLabel), TimeSpan.FromTicks(System.Environment.TickCount - _ticks).TotalSeconds.ToString());
                //labelTime.Text = TimeSpan.FromTicks(System.Environment.TickCount - _ticks).TotalSeconds.ToString();
            }).Start();
        }

        private void CreateListClick(object sender, EventArgs e)
        {
            for(int i = 0 ; i < 10000000 ; i ++)
            {
                _drinks.Add(new Drink()
                    {
                        Name = string.Format("Drink {0}" , i),
                        Price = 0.5                
                    });
            }

            labelListCreated.Text = "Created";
        }

        public async Task<string> CreateTaskFuture()
        {
            Thread.Sleep(1000);
            return "Hello world";
        }              
    }
}
