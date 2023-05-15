using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WSUniversalLib
{
    public class Calculation
    {
        /// <summary>
        /// Метод рассчитывает целое количество сырья, необходимого для производства определенного количества продукции, учитывая возможный брак материалов.
        /// Для упрощения расчетов продукция будет считаться прямооугольной формы
        /// </summary>
        /// <param name="productType"> тип продукции </param>
        /// <param name="materialType">тип материла</param>
        /// <param name="count"> количество продукции </param>
        /// <param name="width"> ширина  </param>
        /// <param name="length"> длина </param>
        /// <returns> Если все данные верны, то возращается количетво необходимого сырья(округленную в большую сторону).Если неверные параметры, то возвращается -1 </returns>

         
        public int GetQuantityForProduct(
            int productType, int materialType,
            int count, float width, float length
            )
        {

            if (count <=0 || width <=0 || length <=0 || productType <=0 || materialType <=0)
                return -1;
            
            float coef = 0;
            float per = 0;
            switch (productType)
            {
                case 1:
                    coef = 1.1f;
                    break;
                case 2:
                    coef = 2.5f;
                    break ;
                case 3:
                    coef = 8.43f;
                    break;
                
            }
            switch (materialType)
            {
                case 1:
                    per = 0.003f;
                    break;
                case 2:
                    per = 0.0012f;
                    break;
            }

            var countproduct = width * length * count * coef;
            countproduct = (int)Math.Ceiling(countproduct);
            float cont = (countproduct * per) + countproduct;
            return (int)Math.Ceiling(cont);
        }

    }
}
