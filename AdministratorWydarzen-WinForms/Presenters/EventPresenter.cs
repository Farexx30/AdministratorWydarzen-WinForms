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
        private readonly IEventView _view;
        private readonly IEventModel _model;
        public IEventView View { get; } = null!;

        public EventPresenter(IEventView view, IEventModel model)
        {
            _view = view;
            _model = model;
        }
    }
}
