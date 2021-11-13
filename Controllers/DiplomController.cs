using System;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Cors;
using Microsoft.EntityFrameworkCore;
using Diplom.DataAccess.Models;

namespace Diplom.Controllers
{
    [ApiController]
    [EnableCors("AllowAllPolicy")]
    [Route("[controller]")]
    public class DiplomController : ControllerBase
    {
        private readonly DiplomContext _context;
        private const int RecordsAmount = 10;

        public DiplomController(DiplomContext context)
        {
            _context = context;
        }

        #region HWaveEOne
        [HttpGet("HWaveEone")]
        public async Task<IEnumerable<HWaveEoneItem>> GetHWaveEone()
        {
            return await _context.HWaveEoneItems.OrderByDescending(e => e.LastModify).Take(RecordsAmount).ToListAsync();
        }

        [HttpGet("HWaveEone/{id:Guid}")]
        public async Task<HWaveEoneItem> GetHWaveEoneById(Guid id)
        {
            return await _context.HWaveEoneItems.FindAsync(id);

            //var all = await _context.HWaveEoneItems.ToListAsync();
            //var needed = all.Where(e => e.Id == id).Single();
            //return needed;
        }

        [HttpPost("HWaveEone")]
        public async Task<IActionResult> SendHWaveEone(HWaveEoneItem hWaveEoneItems)
        {
            hWaveEoneItems.Id = Guid.NewGuid();
            hWaveEoneItems.LastModify = DateTime.UtcNow;

            await _context.AddAsync(hWaveEoneItems);
            await _context.SaveChangesAsync();

            return Ok();
        }
        #endregion

        #region HWaveWOne
        [HttpGet("HWaveWone")]
        public async Task<IEnumerable<HWaveWoneItem>> GetHWaveWone()
        {
            return await _context.HWaveWoneItems.OrderByDescending(e => e.LastModify).Take(RecordsAmount).ToListAsync();
        }

        [HttpGet("HWaveWone/{id:Guid}")]
        public async Task<HWaveWoneItem> GetHWaveWoneById(Guid id)
        {
            return await _context.HWaveWoneItems.FindAsync(id);
        }

        [HttpPost("HWaveWone")]
        public async Task<IActionResult> SendHWaveWone(HWaveWoneItem hWaveWoneItems)
        {
            hWaveWoneItems.Id = Guid.NewGuid();
            hWaveWoneItems.LastModify = DateTime.UtcNow;

            await _context.AddAsync(hWaveWoneItems);
            await _context.SaveChangesAsync();

            return Ok();
        }
        #endregion



        #region HWaveE

        [HttpGet("HWaveE/{SourcesAmount:int}")]
        public async Task<IEnumerable<HWaveEItem>> GetHWaveE(int? SourcesAmount)
        {
            return await _context.HWaveEItem.Where(i => i.SourcesAmount == SourcesAmount.Value).OrderByDescending(e => e.LastModify).Include(e => e.HWaveESourceItems).Take(RecordsAmount).ToListAsync();
        }

        [HttpGet("HWaveE/{id:Guid}")]
        public async Task<HWaveEItem> GetHWaveEById(Guid id)
        {
            return await _context.HWaveEItem.Include(e => e.HWaveESourceItems).Where(e => e.HWaveEItemId == id).FirstOrDefaultAsync();
        }

        [HttpPost("HWaveE")]
        public async Task<IActionResult> SendHWaveEone(HWaveEItem hWaveEItems)
        {
            var HWaveEItemId = Guid.NewGuid();

            hWaveEItems.HWaveEItemId = HWaveEItemId;
            hWaveEItems.LastModify = DateTime.UtcNow;
            hWaveEItems.HWaveESourceItems = hWaveEItems.HWaveESourceItems.Select(i => { i.HWaveESourceItemId = Guid.NewGuid(); i.HWaveEItemId = HWaveEItemId; return i; }).ToList();

            //var processed = hWaveEItems.Select(e =>
            //    {
            //        e.HWaveEItemId = HWaveEItemId;
            //        e.LastModify = DateTime.UtcNow;
            //        e.HWaveESourceItems = e.HWaveESourceItems.Select(i => { i.HWaveESourceItemId = Guid.NewGuid(); i.HWaveEItemId = HWaveEItemId; return i; }).ToList();
            //        return e;
            //    }).ToList();

            await _context.AddAsync(hWaveEItems);
            await _context.SaveChangesAsync();

            return Ok();
        }
        #endregion

        #region HWaveW
        [HttpGet("HWaveW/{SourcesAmount:int}")]
        public async Task<IEnumerable<HWaveWItem>> GetHWaveW(int? SourcesAmount)
        {
            return await _context.HWaveWItem.Where(i => i.SourcesAmount == SourcesAmount.Value).OrderByDescending(e => e.LastModify).Include(e => e.HWaveWSourceItems).Take(RecordsAmount).ToListAsync();
        }

        [HttpGet("HWaveW/{id:Guid}")]
        public async Task<HWaveWItem> GetHWaveWById(Guid id)
        {
            return await _context.HWaveWItem.Include(e => e.HWaveWSourceItems).Where(e => e.HWaveWItemId == id).FirstOrDefaultAsync();
        }

        [HttpPost("HWaveW")]
        public async Task<IActionResult> SendHWaveWone(HWaveWItem hWaveWItems)
        {
            var HWaveWItemId = Guid.NewGuid();

            hWaveWItems.HWaveWItemId = HWaveWItemId;
            hWaveWItems.LastModify = DateTime.UtcNow;
            hWaveWItems.HWaveWSourceItems = hWaveWItems.HWaveWSourceItems.Select(i => { i.HWaveWItemId = Guid.NewGuid(); i.HWaveWItemId = HWaveWItemId; return i; }).ToList();

            await _context.AddAsync(hWaveWItems);
            await _context.SaveChangesAsync();

            return Ok();
        }
        #endregion



        #region LWaveEr
        [HttpGet("LWaveEr/{SourcesAmount:int}")]
        public async Task<IEnumerable<LWaveErItem>> GetLWaveEr(int? SourcesAmount)
        {
            return await _context.LWaveErItem.Where(i => i.SourcesAmount == SourcesAmount.Value).OrderByDescending(e => e.LastModify).Include(e => e.LWaveErSourceItems).Take(RecordsAmount).ToListAsync();
        }

        [HttpGet("LWaveEr/{id:Guid}")]
        public async Task<LWaveErItem> GetLWaveErById(Guid id)
        {
            return await _context.LWaveErItem.Include(e => e.LWaveErSourceItems).Where(e => e.LWaveErItemId == id).FirstOrDefaultAsync();
        }

        [HttpPost("LWaveEr")]
        public async Task<IActionResult> SendLWaveEr(LWaveErItem hWaveWItems)
        {
            var LWaveErItemId = Guid.NewGuid();

            hWaveWItems.LWaveErItemId = LWaveErItemId;
            hWaveWItems.LastModify = DateTime.UtcNow;
            hWaveWItems.LWaveErSourceItems = hWaveWItems.LWaveErSourceItems.Select(i => { i.LWaveErSourceItemId = Guid.NewGuid(); i.LWaveErItemId = LWaveErItemId; return i; }).ToList();

            await _context.AddAsync(hWaveWItems);
            await _context.SaveChangesAsync();

            return Ok();
        }
        #endregion

        #region LWaveP
        [HttpGet("LWaveP/{SourcesAmount:int}")]
        public async Task<IEnumerable<LWavePItem>> GetLWaveP(int? SourcesAmount)
        {
            return await _context.LWavePItem.Where(i => i.SourcesAmount == SourcesAmount.Value).OrderByDescending(e => e.LastModify).Include(e => e.LWavePSourceItems).Take(RecordsAmount).ToListAsync();
        }

        [HttpGet("LWaveP/{id:Guid}")]
        public async Task<LWavePItem> GetLWavePById(Guid id)
        {
            return await _context.LWavePItem.Include(e => e.LWavePSourceItems).Where(e => e.LWavePItemId == id).FirstOrDefaultAsync();
        }

        [HttpPost("LWaveP")]
        public async Task<IActionResult> SendLWaveP(LWavePItem hWaveWItems)
        {
            var LWavePItemId = Guid.NewGuid();

            hWaveWItems.LWavePItemId = LWavePItemId;
            hWaveWItems.LastModify = DateTime.UtcNow;
            hWaveWItems.LWavePSourceItems = hWaveWItems.LWavePSourceItems.Select(i => { i.LWavePSourceItemId = Guid.NewGuid(); i.LWavePItemId= LWavePItemId; return i; }).ToList();

            await _context.AddAsync(hWaveWItems);
            await _context.SaveChangesAsync();

            return Ok();
        }
        #endregion

        #region LWaveHr
        [HttpGet("LWaveHr/{SourcesAmount:int}")]
        public async Task<IEnumerable<LWaveHrItem>> GetLWaveHr(int? SourcesAmount)
        {
            return await _context.LWaveHrItem.Where(i => i.SourcesAmount == SourcesAmount.Value).OrderByDescending(e => e.LastModify).Include(e => e.LWaveHrSourceItems).Take(RecordsAmount).ToListAsync();
        }

        [HttpGet("LWaveHr/{id:Guid}")]
        public async Task<LWaveHrItem> GetLWaveHrById(Guid id)
        {
            return await _context.LWaveHrItem.Include(e => e.LWaveHrSourceItems).Where(e => e.LWaveHrItemId == id).FirstOrDefaultAsync();
        }

        [HttpPost("LWaveHr")]
        public async Task<IActionResult> SendLWaveHr(LWaveHrItem hWaveWItems)
        {
            var LWaveHrItemId = Guid.NewGuid();

            hWaveWItems.LWaveHrItemId = LWaveHrItemId;
            hWaveWItems.LastModify = DateTime.UtcNow;
            hWaveWItems.LWaveHrSourceItems = hWaveWItems.LWaveHrSourceItems.Select(i => { i.LWaveHrSourceItemId = Guid.NewGuid(); i.LWaveHrItemId = LWaveHrItemId; return i; }).ToList();

            //var processed = hWaveWItems.Select(e =>
            //{
            //    e.LWaveHrItemId = LWaveHrItemId;
            //    e.LastModify = DateTime.UtcNow;
            //    e.LWaveHrSourceItems = e.LWaveHrSourceItems.Select(i => { i.LWaveHrSourceItemId = Guid.NewGuid(); i.LWaveHrItemId = LWaveHrItemId; return i; }).ToList();
            //    return e;
            //}).ToList();

            await _context.AddAsync(hWaveWItems);
            await _context.SaveChangesAsync();

            return Ok();
        }
        #endregion

        #region LWavem
        [HttpGet("LWavem/{SourcesAmount:int}")]
        public async Task<IEnumerable<LWavemItem>> GetLWavem(int? SourcesAmount)
        {
            return await _context.LWavemItem.Where(i => i.SourcesAmount == SourcesAmount.Value).OrderByDescending(e => e.LastModify).Include(e => e.LWavemSourceItems).Take(RecordsAmount).ToListAsync();
        }

        [HttpGet("LWavem/{id:Guid}")]
        public async Task<LWavemItem> GetLWavemById(Guid id)
        {
            return await _context.LWavemItem.Include(e => e.LWavemSourceItems).Where(e => e.LWavemItemId == id).FirstOrDefaultAsync();
        }

        [HttpPost("LWavem")]
        public async Task<IActionResult> SendLWavem(LWavemItem hWaveWItems)
        {
            var LWavemItemId = Guid.NewGuid();

            hWaveWItems.LWavemItemId = LWavemItemId;
            hWaveWItems.LastModify = DateTime.UtcNow;
            hWaveWItems.LWavemSourceItems = hWaveWItems.LWavemSourceItems.Select(i => { i.LWavemSourceItemId = Guid.NewGuid(); i.LWavemItemId = LWavemItemId; return i; }).ToList();

            await _context.AddAsync(hWaveWItems);
            await _context.SaveChangesAsync();

            return Ok();
        }
        #endregion

    }
}
