using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_4
{
    public class CollectionType<T> : IEnumerable
    {

        /// <summary>
        /// Список обобщенной коллекции
        /// </summary>
        private List<T> _list;
        /// <summary>
        /// Размер коллекции
        /// </summary>
        public int Count { get { return _list.Count; } }

        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public CollectionType()
        {
            _list = new List<T>();
        }

        /// <summary>
        /// Метод добавления объекта в коллекцию
        /// </summary>
        /// <param name="item">Объект для добавления</param>
        public void Add(T item)
        {
            _list.Add(item);
        }

        /// <summary>
        /// Метод удаления объекта из коллекции
        /// </summary>
        /// <param name="index">Индекс объекта в коллекции</param>
        public void RemoveAt(int index)
        {
            _list.RemoveAt(index);
        }

        /// <summary>
        /// Копирует значения другой коллекции, удаляя ранее имеющиеся
        /// </summary>
        /// <param name="other">Коллекция из которой нужно скопировать</param>
        public void Copy(CollectionType<T> other)
        {
            _list.Clear();
            for (int i = 0; i < other._list.Count; i++)
            {
                _list.Add(other._list[i]);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Sort()
        {
            _list.Sort();
        }

        public IEnumerator GetEnumerator()
        {
            return _list.GetEnumerator();
        }

        public List<T> GetList()
        {
            return _list;
        }

        /// <summary>
        /// Индексатор
        /// </summary>
        /// <param name="index">Индекс объекта в коллекции</param>
        /// <returns>Объект по указанному индексу</returns>
        public T this[int index]
        {
            get => _list[index];
            set => _list[index] = value;
        }
    }
}
