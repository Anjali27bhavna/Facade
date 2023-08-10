﻿using SamsungService.Models;

namespace SamsungService.Repositories
{
    public interface IPartRepository
    {
        Part GetPartById(int partId);
        List<Part> GetAllParts();
        List<Part> SearchPartsByNameOrDescription(string searchText);
        void UpdatePart(int partId, Part updatedPart);
        void AddPart(Part part);
        void DeletePart(int partId);
    }
}
