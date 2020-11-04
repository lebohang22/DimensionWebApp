using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DimensionWebApp.Data;
using DimensionWebApp.Models;

namespace DimensionWebApp.Controllers
{
    public class Cmpg323Project2Dataset3Controller : Controller
    {
        private readonly DimensionDataWebContext _context;

        public Cmpg323Project2Dataset3Controller(DimensionDataWebContext context)
        {
            _context = context;
        }

        // GET: Cmpg323Project2Dataset3
        public async Task<IActionResult> Index()
        {
            return View(await _context.Cmpg323Project2Dataset3.ToListAsync());
        }

        // GET: Cmpg323Project2Dataset3/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cmpg323Project2Dataset3 = await _context.Cmpg323Project2Dataset3
                .FirstOrDefaultAsync(m => m.EmployeeNumber == id);
            if (cmpg323Project2Dataset3 == null)
            {
                return NotFound();
            }

            return View(cmpg323Project2Dataset3);
        }

        // GET: Cmpg323Project2Dataset3/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Cmpg323Project2Dataset3/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Age,Attrition,BusinessTravel,DailyRate,Department,DistanceFromHome,Education,EducationField,EmployeeCount,EmployeeNumber,EnvironmentSatisfaction,Gender,HourlyRate,JobInvolvement,JobLevel,JobRole,JobSatisfaction,MaritalStatus,MonthlyIncome,MonthlyRate,NumCompaniesWorked,Over18,OverTime,PercentSalaryHike,PerformanceRating,RelationshipSatisfaction,StandardHours,StockOptionLevel,TotalWorkingYears,TrainingTimesLastYear,WorkLifeBalance,YearsAtCompany,YearsInCurrentRole,YearsSinceLastPromotion,YearsWithCurrManager")] Cmpg323Project2Dataset3 cmpg323Project2Dataset3)
        {
            if (ModelState.IsValid)
            {
                _context.Add(cmpg323Project2Dataset3);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(cmpg323Project2Dataset3);
        }

        // GET: Cmpg323Project2Dataset3/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cmpg323Project2Dataset3 = await _context.Cmpg323Project2Dataset3.FindAsync(id);
            if (cmpg323Project2Dataset3 == null)
            {
                return NotFound();
            }
            return View(cmpg323Project2Dataset3);
        }

        // POST: Cmpg323Project2Dataset3/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Age,Attrition,BusinessTravel,DailyRate,Department,DistanceFromHome,Education,EducationField,EmployeeCount,EmployeeNumber,EnvironmentSatisfaction,Gender,HourlyRate,JobInvolvement,JobLevel,JobRole,JobSatisfaction,MaritalStatus,MonthlyIncome,MonthlyRate,NumCompaniesWorked,Over18,OverTime,PercentSalaryHike,PerformanceRating,RelationshipSatisfaction,StandardHours,StockOptionLevel,TotalWorkingYears,TrainingTimesLastYear,WorkLifeBalance,YearsAtCompany,YearsInCurrentRole,YearsSinceLastPromotion,YearsWithCurrManager")] Cmpg323Project2Dataset3 cmpg323Project2Dataset3)
        {
            if (id != cmpg323Project2Dataset3.EmployeeNumber)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(cmpg323Project2Dataset3);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Cmpg323Project2Dataset3Exists(cmpg323Project2Dataset3.EmployeeNumber))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(cmpg323Project2Dataset3);
        }

        // GET: Cmpg323Project2Dataset3/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cmpg323Project2Dataset3 = await _context.Cmpg323Project2Dataset3
                .FirstOrDefaultAsync(m => m.EmployeeNumber == id);
            if (cmpg323Project2Dataset3 == null)
            {
                return NotFound();
            }

            return View(cmpg323Project2Dataset3);
        }

        // POST: Cmpg323Project2Dataset3/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var cmpg323Project2Dataset3 = await _context.Cmpg323Project2Dataset3.FindAsync(id);
            _context.Cmpg323Project2Dataset3.Remove(cmpg323Project2Dataset3);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool Cmpg323Project2Dataset3Exists(string id)
        {
            return _context.Cmpg323Project2Dataset3.Any(e => e.EmployeeNumber == id);
        }
    }
}
