using Cine__backend.Interfaces;
using Cine__backend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using Cine__backend.Context;

namespace Cine__backend.Repositories
{
    public class SectionRepository : ISectionRepository
    {
        private AppDbContext _context;
        public SectionRepository(AppDbContext context)
        {
            _context = context;
        }
        public Section AddSection(Section section)
        {
            section.Id = Guid.NewGuid();
            _context.Sections.Add(section);
            _context.SaveChanges();
            return section;
        }

        public Section GetSection(Guid id)
        {
            var section = _context.Sections.Find(id);
            if (section == null)
            {
                throw new KeyNotFoundException("No se encuentra la sección especificada");
            }
            return section;
        }

        public List<Section> GetSections()
        {
            return _context.Sections.ToList();
        }

        public void RemoveSection(Guid sectionId)
        {
            var section = _context.Sections.Find(sectionId);
            if (section == null)
            {
                throw new KeyNotFoundException("No se encuentra la sección especificada");
            }
            _context.Sections.Remove(section);
            _context.SaveChanges();
            return;
        }

        public Section UpdateSection(Section section)
        {
            var currSection = _context.Sections.Find(section.Id);
            if (currSection == null)
            {
                throw new KeyNotFoundException("No se encuentra la sección especificada");
            }
            currSection.Name = section.Name;
            _context.Sections.Update(currSection);
            _context.SaveChanges();
            return section;
        }
    }
}
