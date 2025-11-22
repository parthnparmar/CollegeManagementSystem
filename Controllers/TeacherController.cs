using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using CollegeManagementSystem.Data;
using CollegeManagementSystem.Models;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;
using System;

namespace CollegeManagementSystem.Controllers
{
    [Authorize(Roles = "Teacher")]
    public class TeacherController : Controller
    {
        private readonly ApplicationDbContext _context;

        public TeacherController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Dashboard()
        {
            var username = User.Identity?.Name;
            var teacher = await _context.Teachers.FirstOrDefaultAsync(t => t.Username == username);
            var teacherId = teacher?.Id ?? string.Empty;
            ViewBag.CourseCount = await _context.Courses.CountAsync(c => c.TeacherId == teacherId);
            return View(teacher);
        }

        public async Task<IActionResult> MarkAttendance(int courseId)
        {
            var students = await _context.Students
                .Where(s => s.CourseId == courseId)
                .ToListAsync();

            ViewBag.CourseId = courseId;
            return View(students);
        }

       
        }
    }
