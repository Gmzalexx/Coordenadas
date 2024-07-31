using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coordenadas
{
    partial class coordenadasmvvm : ObservableObject
    {
        [ObservableProperty]
        public string x1;

        [ObservableProperty]
        public string y1;

        [ObservableProperty]
        public string x2;

        [ObservableProperty]
        public string y2;

        [ObservableProperty]
        public string distancia;

        [RelayCommand]
        private void CalcularDistancia()
        {
            if (double.TryParse(X1, out double x1Value) && double.TryParse(Y1, out double y1Value) && double.TryParse(X2, out double x2Value) &&double.TryParse(Y2, out double y2Value))
            {
                double distanciaValue = Math.Sqrt(Math.Pow(x2Value - x1Value, 2) + Math.Pow(y2Value - y1Value, 2));
                Distancia = distanciaValue.ToString();
            }
            else
            {
                Distancia = "Ingresa números válidos para la app";
            }
        }
    }
}
