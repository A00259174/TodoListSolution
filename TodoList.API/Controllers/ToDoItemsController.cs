// GET: api/ToDoItems
using Microsoft.AspNetCore.Mvc;

[HttpGet]
public async Task<ActionResult<IEnumerable<ToDoItem>>> GetIncompleteItems([FromQuery] int pageNumber, [FromQuery] int pageSize)
{
    try
    {
        var incompleteItems = await _context.ToDoItems
          .AsNoTracking() // for performance
          .Where(i => i.CompletedDate == null)
          .Skip(pageNumber * pageSize) // paging
          .Take(pageSize) // paging
          .ToListAsync();

        if (!incompleteItems.Any())
        {
            return NotFound();
        }

        return incompleteItems;

    }
    catch (Exception ex)
    {
        // log error

        return StatusCode(500, "Error retrieving incomplete items");
    }
}