using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace WindowsFormsApp7
{
    [Table(Name = "Материал")]
    public class Мат
    {
        [Column(IsPrimaryKey = true, IsDbGenerated = true)]
        public int ID { get; set; }
        [Column]
        public string Материал { get; set; }
        [Column]
        public string Вес { get; set; }
    }
    [Table(Name = "Мебель")]
    public class Меб
    {
        [Column(IsPrimaryKey = true, IsDbGenerated = true)]
        public int ID { get; set; }
        [Column]
        public string Имя { get; set; }
        [Column]
        public int Цена { get; set; }
        [Column]
        public int Цвет { get; set; }
        [Column]
        public int Количество { get; set; }
        [Column]
        public int Материал { get; set; }
    }
    [Table(Name = "Цвет")]
    public class Цве
    {
        [Column(IsPrimaryKey = true, IsDbGenerated = true)]
        public int ID { get; set; }
        [Column]
        public int Цвет { get; set; }
        
    }
    [Table(Name = "Заказ")]
    public class Зак
    {
        [Column(IsPrimaryKey = true, IsDbGenerated = true)]
        public int ID { get; set; }
        [Column]
        public int Мебель { get; set; }
        [Column]
        public string Количество { get; set; }
        [Column]
        public string ДатаЗаказа { get; set; }
        [Column]
        public string ДатаПоставки { get; set; }
        [Column]
        public int Город { get; set; }
    }
        [Table(Name = "Города")]
        public class Гор
        {
            [Column(IsPrimaryKey = true, IsDbGenerated = true)]
            public int ID { get; set; }
            [Column]
            public string Город { get; set; }
        }
}

    
    
