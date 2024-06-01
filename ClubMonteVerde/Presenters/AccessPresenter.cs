using ClubMonteVerde.Classes.Mappers.Membership;
using ClubMonteVerde.Models;
using ClubMonteVerde.Repository.Entrada;
using ClubMonteVerde.Views.Entrada;
using ClubMonteVerde.Views.MainView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubMonteVerde.Presenters
{
    public class AccessPresenter
    {
        public readonly IScannQR _view;
        private readonly IMainView _mainView;
        private readonly EntradaRepository _entradaRepository;
        private readonly MembershipMapper _membershipMapper;

        public AccessPresenter(IScannQR view, IMainView mainView)
        {
            _view = view ?? throw new ArgumentNullException(nameof(view));
            _mainView = mainView ?? throw new ArgumentNullException(nameof(mainView));
            _entradaRepository = new EntradaRepository();
            _membershipMapper = new MembershipMapper();
            _view.SearchQrValue += SearchClient;
        }

        private void SearchClient(object? sender, EventArgs e)
        {
            string qrValue = _view.GetQrValue();

            if (string.IsNullOrEmpty(qrValue))
            {
                return;
            }

            var membership = _entradaRepository.GetMembership(qrValue);

            if (membership == null)
            {
                MessageBox.Show("Error en la verificación, por favor intente de nuevo", "Error de autentificacion de socio", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var membershipFormat = _membershipMapper.GetMembershipMap(membership);

            _view.SetData(membershipFormat);
        }
    }
}
