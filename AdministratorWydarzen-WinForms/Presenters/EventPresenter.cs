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

    internal class EventPresenter : IEventPresenter
    {
        private readonly IEventModel _model;
        public IEventView View { get; }

        public EventPresenter(IEventModel model, IEventView view)
        {
            _model = model;
            View = view;
        }
    }
}
