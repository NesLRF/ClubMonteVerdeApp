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

            string userNombre;
            string userGrado;
            string userEstatus;

            if (!membership.Any())
            {
                (var familiarMembership, string userData) = _entradaRepository.GetFamiliarMembership(qrValue);

                if (!familiarMembership.Any())
                {
                    MessageBox.Show("Error en la verificación, por favor intente de nuevo", "Error de autentificacion de socio", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                membership = familiarMembership;

                string[] splitUserData = userData!.Split(",");

                userNombre = splitUserData[0];
                userGrado = splitUserData[1];
                userEstatus = splitUserData[2];
            }
            else
            {
                _entradaRepository.SaveSocioEntrada((int)membership.First().socio_titular_id!);

                var user = membership.First();

                userNombre = user.Titular!.nombres + " " + user.Titular.apellidos;
                userGrado = user.Titular.grado_familiar!;
                userEstatus = user.Titular.Estatus!.nombre!;
            }

            var membershipFormat = _membershipMapper.GetMembershipMap(membership);

            _view.SetData(membershipFormat, userNombre, userGrado, userEstatus);
        }
    }
}
