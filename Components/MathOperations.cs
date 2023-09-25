using System;
using Components.CustomExceptions;

namespace Components
{
    public class MathOperations
    {
        public decimal CalculateGain(decimal pricePur, decimal gain, bool isPercentage)
        {
            decimal result = 0;

            if (isPercentage)
                result = pricePur / (1 - (gain / 100));
            else
                result = pricePur + gain;

            return decimal.Round(result, 2);
        }

        public decimal CalculateDiscount(decimal number, decimal discount, bool isPercentage)
        {
            if (isPercentage)
            {
                if (discount > 100)
                    throw new InvalidDiscountException("El descuento no puede ser mayor al 100%");
                else
                    return decimal.Round((number * discount) / 100, 2);
            }
            else
            {
                if (discount > number)
                    throw new InvalidDiscountException("Descuento se aplica al precio unitario\n\nEl descuento no puede ser mayor al precio unitario");
                else
                    return discount;
            }
        }

        public decimal RoundUp(decimal value)//APROXIMA EL VALOR EN ESCALA DE 0.25 (EJEMPLO 10.23 APROXIMA A 10.25)
        {
            if (value.ToString().Contains("."))
            {
                string[] getDec = value.ToString().Split('.');
                double dec = double.Parse(getDec[1]);
                decimal result;

                if (dec > 0)
                {
                    dec = dec / 100;
                    if (dec <= 0.25)
                        result = Convert.ToDecimal(double.Parse(getDec[0]) + 0.25);
                    else if (dec <= 0.5)
                        result = Convert.ToDecimal(double.Parse(getDec[0]) + 0.5);
                    else if (dec <= 0.75)
                        result = Convert.ToDecimal(double.Parse(getDec[0]) + 0.75);
                    else
                        result = Convert.ToDecimal(double.Parse(getDec[0]) + 1);
                }
                else
                    result = value;

                return decimal.Round(result, 2);

            }
            else
                return decimal.Round(value, 2);
        }

        public decimal RoundDown(decimal value)//APROXIMA EL VALOR EN ESCALA DE -0.25 (EJEMPLO 10.23 APROXIMA A 10.00)
        {
            if (value.ToString().Contains("."))
            {
                string[] getDec = value.ToString().Split('.');
                double dec = double.Parse(getDec[1]);
                decimal result;

                if (dec > 0)
                {
                    dec = dec / 100;
                    if (dec >= 0.75)
                        result = Convert.ToDecimal(double.Parse(getDec[0]) + 0.75);
                    else if (dec >= 0.5)
                        result = Convert.ToDecimal(double.Parse(getDec[0]) + 0.5);
                    else if (dec >= 0.25)
                        result = Convert.ToDecimal(double.Parse(getDec[0]) + 0.25);
                    else
                        result = Convert.ToDecimal(double.Parse(getDec[0]) + 0);
                }
                else
                    result = value;

                return decimal.Round(result, 2);

            }
            else
                return decimal.Round(value, 2);
        }
    }
}
