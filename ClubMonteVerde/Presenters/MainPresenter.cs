using ClubMonteVerde.Views.Entrada;
using ClubMonteVerde.Views.MainView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubMonteVerde.Presenters
{
    public class MainPresenter
    {
        private readonly IMainView _view;

        public MainPresenter(IMainView view)
        {
            _view = view;

            _view.ScannQrCode += ShowScannQrCodeView;
            _view.ShowEnterSociosList += ShowEnterSociosView;
            _view.ShowEnterVisitsList += ShowEnterVisitsView;
            _view.AddVisit += ShowAddVisitView;
            _view.AddSocio += ShowAddSocioView;
            _view.ShowAllSociosList += ShowAllSociosView;
            _view.AddMembership += ShowAddMembershipView;
            _view.ShowAllMembershipList += ShowAllMembershipView;
        }

        private void ShowAllMembershipView(object? sender, EventArgs e)
        {
            _view.CloseActiveForm();
        }

        private void ShowAddMembershipView(object? sender, EventArgs e)
        {
            _view.CloseActiveForm();
        }

        private void ShowAllSociosView(object? sender, EventArgs e)
        {
            _view.CloseActiveForm();
        }

        private void ShowAddSocioView(object? sender, EventArgs e)
        {
            _view.CloseActiveForm();
        }

        private void ShowAddVisitView(object? sender, EventArgs e)
        {
            _view.CloseActiveForm();
        }

        private void ShowEnterVisitsView(object? sender, EventArgs e)
        {
            _view.CloseActiveForm();
        }

        private void ShowEnterSociosView(object? sender, EventArgs e)
        {
            _view.CloseActiveForm();
        }

        private void ShowScannQrCodeView(object? sender, EventArgs e)
        {
            _view.CloseActiveForm();
            IScannQR view = ScannQR.GetInstance((MainView)_view);
            new AccessPresenter(view, _view);
        }
    }
}
