﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BazingaPizzaria.Model
{
    class Price
    {

        #region Fields

        private decimal _beverageSm = 1.19M;
        private decimal _beverageMd = 1.69M;
        private decimal _beverageLg = 2.19M;
        private decimal _beverageXL = 2.69M;
        //private decimal _specialtyExtra = 3.00M;
        //private decimal _toppingExtra = 1.00M;
        private decimal _pizzaSm = 3.99M;
        private decimal _pizzaMed = 7.99M;
        private decimal _pizzaLg = 10.97M;
        private decimal _pizzaXlg = 13.97M;

        #endregion

        #region Properties
        public decimal BeverageSm
        {
            get { return _beverageSm; }
        }

        public decimal BeverageMd
        {
            get { return _beverageMd; }
        }

        public decimal BeverageLg
        {
            get { return _beverageLg; }
        }

        public decimal BeverageXL 
        {
            get { return _beverageXL; }  
        }

        public decimal PizzaSm
        {
            get { return _pizzaSm; }
        }

        public decimal PizzaMed
        {
            get { return _pizzaMed; }
        }

        public decimal PizzaLg
        {
            get { return _pizzaLg; }
        }

        public decimal PizzaXlg
        {
            get { return _pizzaXlg; }
        }

        #endregion

        #region Constructors
        public Price()
        {

        }
        #endregion
    }
}
