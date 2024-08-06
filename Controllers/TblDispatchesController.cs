using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Webfront.Models;

namespace Webfront.Controllers
{
    public class TblDispatchesController : Controller
    {
        private readonly AppDbContext _context;

        public TblDispatchesController(AppDbContext context)
        {
            _context = context;
        }

        // GET: TblDispatches
        public async Task<IActionResult> Indexold()
        {
              return _context.TblDispatches != null ? 
                          View(await _context.TblDispatches.ToListAsync()) :
                          Problem("Entity set 'AppDbContext.TblDispatches'  is null.");
        }



        // GET: TblDispatches
        public async Task<IActionResult> Index(int page = 1)
        {
            const int pageSize = 60;
            var dispatches = await _context.TblDispatches
                //.OrderBy(d => d.Id)
                .OrderByDescending(d=>d.Id)
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .ToListAsync();

            var totalItems = await _context.TblDispatches.CountAsync();

            var model = new DispatchListViewModel
            {
                Dispatches = dispatches,
                Pagination = new PaginationViewModel
                {
                    CurrentPage = page,
                    TotalItems = totalItems,
                    PageSize = pageSize
                }
            };

            return View(model);
        }

        // other actions...

        // GET: TblDispatches/Details/5xxxxxxxxx
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.TblDispatches == null)
            {
                return NotFound();
            }

            var tblDispatch = await _context.TblDispatches
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tblDispatch == null)
            {
                return NotFound();
            }

            return View(tblDispatch);
        }



        //x   partyname list 
        [HttpGet]
        public async Task<IActionResult> GetPartyNames()
        {
            var partyNames = await _context.Tblpartynamelists
                .Select(p => new { p.Partyname })
                .ToListAsync();

            return Json(partyNames);
        }
        [HttpGet]
        public async Task<IActionResult> GetPartyNamesLIKE(string term)
        {
            var partyNames = await _context.Tblpartynamelists
                .Where(p => EF.Functions.Like(p.Partyname, $"%{term}%"))
                .Select(p => new { p.Partyname })
                .ToListAsync();

            return Json(partyNames);
        }
        public IActionResult GetPartyNamesx(string term)
        {
            var partyNames = _context.Tblpartynamelists
                .Where(p => p.Partyname.Contains(term))
                .Select(p => p.Partyname)
                .Distinct()
                .ToList();

            return Json(partyNames);
        }


        private bool TblDispatchExists(int? id)
        {
            return (_context.TblDispatches?.Any(e => e.Id == id)).GetValueOrDefault();
        }





        // GET: TblDispatches/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: TblDispatches/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Chalanno,RegOrStock,Datex,Timex,Monthnamex,Yearnamex,Partyname,Txtpartynamesearched,Site,Vehicleno,Drivername,Supervisorname,Material,Trip,Ton,Qty,RateFromchart,TransportCharge,RateApplied,Amount1,Gstcustomer,GstAmount,TotalAmountBill,Discountpercent,Royalty,Payablebillwithdiscount,CashPaymentRs,OnlinePaymentRs,Summary,JamaAmt,Monthnumber")] TblDispatch tblDispatch)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tblDispatch);
                await _context.SaveChangesAsync();
                // return RedirectToAction(nameof(Index)); //index webpage         // Pass success message to the view
                TempData["SuccessMessagex"] = "Form submitted successfully!";

            }
            return View(tblDispatch);
        }

        // GET: TblDispatches/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.TblDispatches == null)
            {
                return NotFound();
            }

            var tblDispatch = await _context.TblDispatches.FindAsync(id);
            if (tblDispatch == null)
            {
                return NotFound();
            }
            return View(tblDispatch);
        }

        // POST: TblDispatches/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int? id, [Bind("Id,Chalanno,RegOrStock,Datex,Timex,Monthnamex,Yearnamex,Partyname,Txtpartynamesearched,Site,Vehicleno,Drivername,Supervisorname,Material,Trip,Ton,Qty,RateFromchart,TransportCharge,RateApplied,Amount1,Gstcustomer,GstAmount,TotalAmountBill,Discountpercent,Royalty,Payablebillwithdiscount,CashPaymentRs,OnlinePaymentRs,Summary,JamaAmt,Monthnumber")] TblDispatch tblDispatch)
        {
            if (id != tblDispatch.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tblDispatch);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TblDispatchExists(tblDispatch.Id))
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
            return View(tblDispatch);
        }

        // GET: TblDispatches/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.TblDispatches == null)
            {
                return NotFound();
            }

            var tblDispatch = await _context.TblDispatches
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tblDispatch == null)
            {
                return NotFound();
            }

            return View(tblDispatch);
        }

        // POST: TblDispatches/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int? id)
        {
            if (_context.TblDispatches == null)
            {
                return Problem("Entity set 'AppDbContext.TblDispatches'  is null.");
            }
            var tblDispatch = await _context.TblDispatches.FindAsync(id);
            if (tblDispatch != null)
            {
                _context.TblDispatches.Remove(tblDispatch);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

       
    }
}
