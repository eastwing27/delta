using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Reflection;

namespace Delta.Data
{
    public class DataManager
    {
        DeltaContext _db;
        Dictionary<Type, IQueryable> _tables;

        public DataManager()
        {
            _db = new DeltaContext();
            _tables = typeof(DeltaContext)
                        .GetProperties(BindingFlags.Public | BindingFlags.Instance)
                        .Select(p => p.GetValue(_db))
                        .Where(p => p is IQueryable)
                        .ToDictionary(p => p.GetType().GetGenericArguments()[0], p => p as IQueryable);
        }

        DbSet<T> getTable<T>() where T : class
        {
            var type = typeof(T);
            if (_tables.Keys.Contains(type))
                return _tables[type] as DbSet<T>;

            throw new ArgumentException($"There is no table of {nameof(T)}");
        }

        public T Read<T>(Predicate<T> Condition) 
            where T : class
        {
            var table = getTable<T>();
            return table.FirstOrDefault(entity => Condition(entity));
        }

        public IQueryable<T> ReadRange<T>(Predicate<T> Condition) 
            where T : class
        {
            var table = getTable<T>();
            return table.Where(entity => Condition(entity));
        }

        public IQueryable<T> ReadAll<T>()
            where T : class
        {
            return getTable<T>() as IQueryable<T>;
        }

        public void Create<T>(T Entity) 
            where T : class
        {
            var table = getTable<T>();
            table.Add(Entity);
        }

        public void CreateRange<T>(IEnumerable<T> Entities) 
            where T : class
        {
            var table = getTable<T>();
            table.AddRange(Entities);
        }

        public void Update<T>(T Entity) 
            where T : class
        {
            var table = getTable<T>();

            _db.Entry(Entity).State = EntityState.Modified;
        }

        public void UpdateRange<T>(IEnumerable<T> Range) 
            where T : class
        {
            foreach (var item in Range)
                _db.Entry(item).State = EntityState.Modified;
        }

        public void Delete<T>(T Entity) where T : class
        {
            var table = getTable<T>();
            table.Remove(Entity);
        }

        public void DeleteRange<T>(IEnumerable<T> Range) 
            where T : class
        {
            var table = getTable<T>();
            table.RemoveRange(Range);
        }

    }
}
