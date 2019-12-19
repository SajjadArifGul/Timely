using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timely.Data.Services
{
    public class ContextHolder
    {
        #region Define as Singleton
        private static ContextHolder _Instance;

        public static ContextHolder Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new ContextHolder();
                }

                return (_Instance);
            }
        }

        private ContextHolder()
        {
        }
        #endregion

        private TimelyContext _TimelyContext;
        public TimelyContext TimelyContext()
        {
            if(_TimelyContext == null)
            {
                _TimelyContext = new TimelyContext();
            }

            return _TimelyContext;
        }
    }
}
