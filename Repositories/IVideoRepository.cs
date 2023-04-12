using System.Collections.Generic;
using Gifter.Models;

namespace Gifter.Repositories
{
    public interface IVideoRepository
    {
        List<Video> GetAll();
        void Add(Video video);
        void Update(Video video);
        void Delete(int id);
        public Video GetById(int id);
        List<Video> GetAllWithComments();

    }
}
