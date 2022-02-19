using System;

namespace StretchCeilings.DataAccess.Repositories
{
    public class Repository : IDisposable
    {
        private readonly StretchCeilingsContext _context;
        private bool _isDisposed;

        public Repository()
        {
            _isDisposed = false;
            _context = new StretchCeilingsContext();
        }

        protected StretchCeilingsContext Context
        {
            get { return _context; }
        }

        public void Dispose()
        {
            _context?.Dispose();
            _isDisposed = true;
        }
    }
}