using ClubMonteVerde.Models;
using ClubMonteVerde.Repository.Entrada;
using ClubMonteVerde.Views.Entrada;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubMonteVerde.Presenters
{
    public class AccessPresenter
    {
        public readonly IAccess _view;
        private readonly EntradaRepository _entradaRepository;

        public AccessPresenter(IAccess view)
        {
            _view = view;
            _entradaRepository = new EntradaRepository();
            _view.SearchClient += SearchClient;
        }

        private void SearchClient(object? sender, EventArgs e)
        {
            string qrValue = _view.GetQrValue();

            if (string.IsNullOrEmpty(qrValue))
            {
                return;
            }

            var membership = _entradaRepository.GetMembership(qrValue)?.First();

            if (membership == null)
            {
                MessageBox.Show("Error en la verificación, por favor intente de nuevo", "Error de autentificacion de socio", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Hola "+ membership.Titular!.nombres +" "+ membership.Titular.apellidos+ " tu membresia es "+ membership.tipo_membresia);
        }
    }
}
