using ObjectOrientedPractics.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using ObjectOrientedPractics.Model.Enumerations;

namespace ObjectOrientedPractics.Model
{
    
    /// <summary>
    /// Описание продукта.
    /// </summary>
    public class Item : ICloneable, IEquatable<Item>, IComparable<Item>
    {
        /// <summary>
        /// Id продукта.
        /// </summary>
        public readonly int _id;
        /// <summary>
        /// Название продукта.
        /// </summary>
        private string _name;
        /// <summary>
        /// Описание продукта.
        /// </summary>
        private string _info;
        
        /// <summary>
        /// Цена продукта.
        /// </summary>
        private double _cost;
        
        public Category Category { get; set; }
        
        /// <summary>
        /// Возвраащает и задает название продукта.
        /// </summary>
        public string Name
        {
            get { return _name; }
            set { if (ValueValidator.AssertStringOnLength(value, 200, Name)) _name = value; }
        }
        /// <summary>
        /// Возвраащает и задает описание продукта.
        /// </summary>
        public string Info
        {
            get { return _info; }
            set { if (ValueValidator.AssertStringOnLength(value, 1000, Info)) _info = value; }
        }
        /// <summary>
        /// Возвраащает и задает цену продукта.
        /// </summary>
        public double Cost
        {
            get { return _cost;}
            set { if (value > 0 && value < 100000) _cost = value; }
        }
        public int Id
        {
            get { return _id; }
        }
        /// <summary>
        /// Создает экземпляр класса <see cref="Item"./>
        /// </summary>
        /// <param name="name">Название продукта.</param>
        /// <param name="info">Описание продукта.</param>
        /// <param name="cost">Цена продукта.</param>
        public Item(string name, string info, double cost, Category category)
        {
            Name = name;
            Info = info;
            Cost = cost;
            _id = IdGenerator.ItemId;
            Category = category;
        }
        public Item()
        {
            _id = IdGenerator.ItemId;
            Category = Category.Food;
            Cost = 47;
            Info = "Без информации";
            Name = "Хлеб";
        }
        public object Clone()
        {
            return new Item(Name, Info, Cost, Category);
        }

        /// <inheritdoc/>
        public bool Equals(Item? item2)
        {
            if (item2 == null)
                return false;
            if (object.ReferenceEquals(this, item2))
                return true;
            return (Id == item2.Id);
        }

        /// <inheritdoc/>
        public int CompareTo(Item? item2)
        {
            if (item2 == null)
                return 1;
            if (object.ReferenceEquals(this, item2))
                return 0;

            if (Cost < item2.Cost)
            {
                return -1;
            }
            else if (Cost == item2.Cost)
            {
                return 0;
            }
            return 1;
        }
    }
}
