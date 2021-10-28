using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infraestrutura.Repositories
{
    public class BaseRepository : IActivofijoRepositories
    {
        protected ActivoFijo[] data;
        
        public void Add(ActivoFijo t, ref ActivoFijo[] data)
        {
            if (data == null)
            {
                data = new ActivoFijo[1];
                data[0] = t;
                return;
            }

            ActivoFijo[] tmp = new ActivoFijo[data.Length + 1];
            Array.Copy(data, tmp, data.Length);
            tmp[tmp.Length - 1] = t;
            data = tmp;
        }

        public void Create(ActivoFijo t)
        {
            Add(t, ref data);
        }

        public ActivoFijo[] FindAll()
        {
            return data;
        }
    }
}
