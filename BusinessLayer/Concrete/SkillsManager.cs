using BusinessLayer.Abstract;
using Entity_Layer.Concrete;
using EntityAccessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class SkillsManager : ISkillsService
    {
        ISkillDal _SkillsDal;

        public SkillsManager(ISkillDal skillsDal)
        {
            _SkillsDal = skillsDal;
        }

        public List<Skill> GetList()
        {
            return _SkillsDal.List();
        }
    }
}
