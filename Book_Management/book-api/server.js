// server.js
const express = require('express');
const {
  getAll,
  getById,
  add,
  update,
  remove,
  bookEvents
} = require('./services/bookService');

const app = express();
const PORT = 3000;

app.use(express.json());

// Root route
app.get('/', (req, res) => {
  res.json({ message: 'Welcome to Book Management API' });
});

// GET /books → all books
app.get('/books', async (req, res) => {
  try {
    const books = await getAll();
    res.json(books);
  } catch (err) {
    res.status(500).json({ error: 'Failed to read books' });
  }
});

// GET /books/:id → book by id
app.get('/books/:id', async (req, res) => {
  try {
    const book = await getById(req.params.id);
    if (!book) return res.status(404).json({ error: 'Book not found' });
    res.json(book);
  } catch (err) {
    res.status(500).json({ error: 'Failed to read book' });
  }
});

// POST /books → add new (title, author)
app.post('/books', async (req, res) => {
  try {
    const book = await add(req.body);
    res.status(201).json(book);
  } catch (err) {
    const code = err.status || 500;
    res.status(code).json({ error: err.message || 'Failed to add book' });
  }
});

// PUT /books/:id → update by id
app.put('/books/:id', async (req, res) => {
  try {
    const updated = await update(req.params.id, req.body);
    if (!updated) return res.status(404).json({ error: 'Book not found' });
    res.json(updated);
  } catch (err) {
    res.status(500).json({ error: 'Failed to update book' });
  }
});

// DELETE /books/:id → delete by id
app.delete('/books/:id', async (req, res) => {
  try {
    const deleted = await remove(req.params.id);
    if (!deleted) return res.status(404).json({ error: 'Book not found' });
    res.json({ message: 'Deleted', book: deleted });
  } catch (err) {
    res.status(500).json({ error: 'Failed to delete book' });
  }
});

// Simple event logging
bookEvents.on('book:added', (b) => console.log('Book Added:', b));
bookEvents.on('book:updated', (b) => console.log('Book Updated:', b));
bookEvents.on('book:deleted', (b) => console.log('Book Deleted:', b));

app.listen(PORT, () => {
  console.log(`Server running on http://localhost:${PORT}`);
});
