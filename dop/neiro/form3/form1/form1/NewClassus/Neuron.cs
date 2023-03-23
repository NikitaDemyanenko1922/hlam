using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace form1.NewClassus
{
    internal class Neuron
    {
        //поля
        double[] input; //входной сигнал
        double[] weight; //синаптические веса
        double output; //выходной сигнал
        double a = 1e-2;
        //свойства
        public double[] Input { get { return input; } set { input = value; } }
        public double[] Weights { get { return weight; } set { weight = value; } }
        //public double[] Weights => weight;
        public double Output { get { return output; } set { output = value; } }
        //методы
 
        //конструктор
        public Neuron(double[] inputs, double[] weights, TypeNeuron type) { type = type; weight = weights; input = inputs; }
        public void Activation(double[] i, double[] w)//нелинейное преобразование
        {
            double sum = w[0];
            for(int j = 1; j < w.Length; j++)
            {
                sum += i[0] * w[j];
            }
            output = LeakyReLU(sum);
        }
        private double LeakyReLU(double sum) => (sum >= 0) ? sum : a * sum;
        private double LeakyReLU_Derivativator(double sum) => (sum >= 0) ? 1 : a * sum;
    }
}
