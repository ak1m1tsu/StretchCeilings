using System;
using System.Collections.Generic;
using StretchCeilings.Domain;

namespace StretchCeilings.DataAccess.Repositories
{
    public abstract class Repository<T> : IRepository<T>, IDisposable where T : class
    {
        private readonly StretchCeilingsContext _context;
        private bool _disposed;

        protected Repository()
        {
            _context = new StretchCeilingsContext();
            _disposed = false;
        }

        protected StretchCeilingsContext Context
        {
            get { return _context; }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (_disposed == false)
                if (disposing)
                    _context?.Dispose();

            _disposed = true;
        }

        public abstract IEnumerable<T> GetAll();

        public abstract T FindById(int id);
    }
}