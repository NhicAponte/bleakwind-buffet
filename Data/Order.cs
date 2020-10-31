using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Text;
using BleakwindBuffet.Data; 

namespace BleakwindBuffet.Data
{
    public class Order : ObservableCollection<IOrderItem> 
    {
        //public event PropertyChangedEventHandler PropertyChanged;

        //public event NotifyCollectionChangedEventHandler CollectionChanged; 
        
        //Order order = new Order();

        public Order()
        {
            CollectionChanged += CollectionChangedListener; 
        }

        private static int nextNumber = 1; 
        public int Number
        {
            get
            {
                return nextNumber++; 
            }
        }

        private double taxRate = 0.12; 
        public double SalesTaxRate
        {
            get
            {
                return taxRate; 
            }
            set
            {
                taxRate = value; 
            }
        }
        private double subTotal = 0; 
        public double Subtotal
        {
            get
            {
                foreach(IOrderItem item in this)
                {
                    subTotal += item.Price; 
                }
                return subTotal; 
            }
        }
        private uint calories = 0; 
        public uint Calories
        {
            get
            {
                foreach(IOrderItem item in this)
                {
                    calories += item.Calories; 
                }
                return calories; 
            }
        }   
        
        public double Tax
        {
            get
            {
                return Subtotal * SalesTaxRate; 
            }
        }   
        
        public double Total
        {
            get
            {
                return Subtotal + Tax; 
            }
        }

        //public int Count => throw new NotImplementedException();

        //public bool IsReadOnly => throw new NotImplementedException();

        private void CollectionChangedListener(object sender, NotifyCollectionChangedEventArgs e)
        {
            OnPropertyChanged(new PropertyChangedEventArgs("Calories")); 
            OnPropertyChanged(new PropertyChangedEventArgs("Subtotal")); 
            OnPropertyChanged(new PropertyChangedEventArgs("Tax")); 
            OnPropertyChanged(new PropertyChangedEventArgs("Total")); 
            switch (e.Action)
            {
                case NotifyCollectionChangedAction.Add:
                    foreach (IOrderItem item in e.NewItems)
                    {
                        item.PropertyChanged += CollectionItemChangedListener;
                    }
                    break;
                case NotifyCollectionChangedAction.Remove:
                    foreach(IOrderItem item in e.NewItems)
                    {
                        item.PropertyChanged -= CollectionItemChangedListener;
                    }
                    break;
                case NotifyCollectionChangedAction.Reset:
                    throw new NotImplementedException("NotifyCollectionChangedAction.Reset not supported");
            }
        }

        void CollectionItemChangedListener(object sender, PropertyChangedEventArgs e)
        {
            if(e.PropertyName == "Price")
            {
                OnPropertyChanged(new PropertyChangedEventArgs("Total"));
                OnPropertyChanged(new PropertyChangedEventArgs("SubTotal"));
                OnPropertyChanged(new PropertyChangedEventArgs("Tax"));
            }
            if(e.PropertyName == "Calories")
            {
                OnPropertyChanged(new PropertyChangedEventArgs("Calories")); 
            }
        }
    }
}
