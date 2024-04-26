using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdministratorWydarzen_WinForms.Models;

namespace AdministratorWydarzen_WinForms.Presenters
{
    public interface IEventPresenter
    {
        public IEventView View { get; }
    }

    public class EventPresenter : IEventPresenter
    {
        public IEventView View { get; }

        public EventPresenter(IEventView view)
        {
            View = view;
        }
    }
}
