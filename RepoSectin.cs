using ConsoleApp8.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp8.Repo
{
    public class RepoSectin
    {

        private Context context = new Context();
        public bool CreateSection(Section section)
        {
            context.Sections.Add(section);
            return context.SaveChanges() > 0;
        }
        public List<Section> GetAllSections()
        {
            return context.Sections.AsNoTracking().ToList();
        }
        public Section? GetSectionsById(int id)
        {
            return context.Sections
                .FirstOrDefault(c => c.SectionID == id);
        }
        public bool UpdateSection(Section category)
        {
            context.Sections.Update(category);
            return context.SaveChanges() > 0;
        }
        public bool DeleteSection(int id)
        {
            Section? category = GetSectionsById(id);

            if (category == null)
                return false;

            context.Sections.Remove(category);
            return context.SaveChanges() > 0;
        }
    }

}
