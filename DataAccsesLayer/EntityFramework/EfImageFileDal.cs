using DataAccsesLayer.Abstract;
using DataAccsesLayer.Concrete.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccsesLayer.EntityFramework
{
    public class EfImageFileDal : GenericRepository<ImageFile>, IImageFileDal
    {

    }
}
