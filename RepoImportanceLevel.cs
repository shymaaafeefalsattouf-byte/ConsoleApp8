using ConsoleApp8.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp8.Repo
{
    public class RepoImportanceLevel
    {
        private Context context = new Context();
        public bool CreateImportanceLevel(ImportanceLevel ImLe)
        {
            context.ImportanceLevels.Add(ImLe);
            return context.SaveChanges() > 0;
        }
        public List<ImportanceLevel> GetAllImportanceLevel()
        {
            return context.ImportanceLevels.AsNoTracking().ToList();
        }

        public ImportanceLevel? GetImportanceLevelById(int id)
        {
            return context.ImportanceLevels
                .FirstOrDefault(Im => Im.LevelId == id);
        }
        public bool UpdateImportanceLevel(ImportanceLevel ImLe)
        {
            context.ImportanceLevels.Update(ImLe);
            return context.SaveChanges() > 0;
        }
        public bool DeleteImportanceLevel(int id)
        {
            ImportanceLevel? ImLe = GetImportanceLevelById(id);

            if (ImLe == null)
                return false;

            context.ImportanceLevels.Remove(ImLe);
            return context.SaveChanges() > 0;
        }
    }
}
