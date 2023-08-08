using CQRSPattern_With_MediatR.Contracts;
using CQRSPattern_With_MediatR.Data;
using CQRSPattern_With_MediatR.Models;
using Microsoft.EntityFrameworkCore;

namespace CQRSPattern_With_MediatR.Repositories
{
    public class StudentRepository : IStudentRepository
    {
        private readonly DbContextClass _dbContextClass;

        public StudentRepository(DbContextClass dbContextClass)
        {
            _dbContextClass = dbContextClass;
        }
        public async Task<StudentDetails> AddStudentAsync(StudentDetails studentDetails)
        {
            var result = _dbContextClass.Students.Add(studentDetails);
            await _dbContextClass.SaveChangesAsync();
            return result.Entity; ;
        }

        public async Task<int> DeleteStudentAsync(int Id)
        {
            var filteredData = _dbContextClass.Students.Where(x => x.Id == Id).FirstOrDefault();
            _dbContextClass.Students.Remove(filteredData);
            return await _dbContextClass.SaveChangesAsync();
        }

        public async Task<StudentDetails> GetStudentByIdAsync(int Id)
        {
            return await _dbContextClass.Students.Where(x => x.Id == Id).FirstOrDefaultAsync() ?? new StudentDetails();
        }

        public async Task<List<StudentDetails>> GetStudentListAsync()
        {
            return await _dbContextClass.Students.ToListAsync();
        }

        public async Task<int> UpdateStudentAsync(StudentDetails studentDetails)
        {
            _dbContextClass.Students.Update(studentDetails);
            return await _dbContextClass.SaveChangesAsync();
        }
    }
}
