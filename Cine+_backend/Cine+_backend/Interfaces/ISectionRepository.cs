using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cine__backend.Models;

namespace Cine__backend.Interfaces
{
    public interface ISectionRepository
    {
        List<Section> GetSections();
        Section GetSection(Guid id);
        Section AddSection(Section section);
        Section UpdateSection(Section section);
        void RemoveSection(Guid sectionId);
    }
}
