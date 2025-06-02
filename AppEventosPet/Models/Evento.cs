using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace AppEventosPet.Models
{
    public class Evento : INotifyPropertyChanged
    {
        private int _numeroParticipantes = 1;
        private double _custoPorParticipante;
        private DateTime _dataInicio = DateTime.Now;
        private DateTime _dataTermino = DateTime.Now;

        public string Nome { get; set; }
        public string Tipo { get; set; }
        public string Cidade { get; set; }

        public DateTime DataInicio
        {
            get => _dataInicio;
            set
            {
                if (_dataInicio != value)
                {
                    _dataInicio = value;
                    OnPropertyChanged();
                    OnPropertyChanged(nameof(DuracaoEmDias));
                    OnPropertyChanged(nameof(CustoTotal));
                }
            }
        }

        public DateTime DataTermino
        {
            get => _dataTermino;
            set
            {
                if (_dataTermino != value)
                {
                    _dataTermino = value;
                    OnPropertyChanged();
                    OnPropertyChanged(nameof(DuracaoEmDias));
                    OnPropertyChanged(nameof(CustoTotal));
                }
            }
        }

        public int NumeroParticipantes
        {
            get => _numeroParticipantes;
            set
            {
                if (_numeroParticipantes != value)
                {
                    _numeroParticipantes = value;
                    OnPropertyChanged();
                    OnPropertyChanged(nameof(CustoTotal));
                }
            }
        }

        public double CustoPorParticipante
        {
            get => _custoPorParticipante;
            set
            {
                if (_custoPorParticipante != value)
                {
                    _custoPorParticipante = value;
                    OnPropertyChanged();
                    OnPropertyChanged(nameof(CustoTotal));
                }
            }
        }

        public int DuracaoEmDias => (DataTermino - DataInicio).Days + 1;

        public double CustoTotal => NumeroParticipantes * CustoPorParticipante * DuracaoEmDias;

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
