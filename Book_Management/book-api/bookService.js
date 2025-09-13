 const path = require("path");
 const filePath = path.join(__dirname, "data", "books.json");
 async function ensureFileExists() {
  try {
    await fs.mkdir(path.dirname(filePath), { recursive: true });
    await fs.access(filePath);
  } catch {
    await fs.writeFile(filePath, JSON.stringify([], null, 2));
  }
 }
 async function readBooks() {
  await ensureFileExists();
  const data = await fs.readFile(filePath, "utf8");
  return JSON.parse(data);
 }
 async function writeBooks(books) {
  await ensureFileExists();
  await fs.writeFile(filePath, JSON.stringify(books, null, 2));
 }
 module.exports = { readBooks, writeBooks };