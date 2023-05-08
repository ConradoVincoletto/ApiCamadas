using Business.InterfaceGenerica;
using Data.Config;
using Microsoft.EntityFrameworkCore;
using Microsoft.Win32.SafeHandles;
using System.Runtime.InteropServices;

namespace Data.RepositorioGenerico
{
    public class RepositoryGeneric<T> : IGeneric<T>, IDisposable where T : class
    {
        private readonly DbContextOptions<Context> _OptionBuilder;
        public RepositoryGeneric()
        {
            _OptionBuilder = new DbContextOptions<Context>();
        }

        public async Task Add(T Objeto)
        {
            using (var data = new Context(_OptionBuilder))
            {
                await data.Set<T>().AddAsync(Objeto);
                await data.SaveChangesAsync();
            }
        }

        public async Task Delete(T Objeto)
        {
            using (var data = new Context(_OptionBuilder))
            {
                data.Set<T>().Remove(Objeto);
                await data.SaveChangesAsync();
            }
        }

        public async Task<T> GetEntityById(int Id)
        {
            using (var data = new Context(_OptionBuilder))
            {
                return await data.Set<T>().FindAsync(Id);
                
            }
        }

        public async Task<List<T>> List()
        {
            using (var data = new Context(_OptionBuilder))
            {
                return await data.Set<T>().ToListAsync();
                
            }
        }

        public async Task Update(T Objeto)
        {
            using (var data = new Context(_OptionBuilder))
            {
                data.Set<T>().Update(Objeto);
                await data.SaveChangesAsync();
            }
        }

        bool disposed = false;

        SafeHandle handle = new SafeFileHandle(IntPtr.Zero, true);

        

        public void Dispose()
        {
            // Dispose of unmanaged resources.
            Dispose(true);
            // Suppress finalization.
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposed)
            {
                return;
            }

            if (disposing)
            {
                handle.Dispose();
            }

            // TODO: free unmanaged resources (unmanaged objects) and override a finalizer below.
            // TODO: set large fields to null.

            disposed = true;
        }
    }
}
