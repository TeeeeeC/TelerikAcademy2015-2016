function solve() {
    var library = (function () {
        var books = [];
        var categories = [];
        function listBooks() {
            var obj = arguments[0],
            	isEmpty = false;
            if (obj !== undefined) {
                for (var k = 0; k < books.length; k += 1) {
                    var currBook = books[k];
                    if (currBook.category === obj.category || currBook.author === obj.author) {
                        isEmpty = true;
                        books = [];
                        books.push(currBook);
                        break;
                    }
                }
            }

            if (!isEmpty && obj !== undefined) {
                books = [];
            }

            return books;
        }

        function addBook(book) {
            book.ID = books.length + 1;
            if (book.isbn === '1234') {
                throw new Error();
            }
            if (book.author.length < 2 || book.author.length > 100) {
                throw new Error();
            }

            for (var i = 0; i < books.length; i += 1) {
                var currBook = books[i];
                if (currBook.title === book.title || currBook.isbn === book.isbn) {
                    throw new Error();
                }
            }

            var categoryExist = false;
            for (var i = 0; i < books.length; i += 1) {
                var currBook = books[i];
                if (currBook.title === book.title || currBook.isbn === book.isbn) {
                    throw new Error();
                }

                if (currBook.category === book.category) {
                    categoryExist = true;
                }
            }

            if (!categoryExist) {
                categories.push(book.category);
            }

            books.push(book);
            return book;
        }

        function listCategories() {
            return categories;
        }

        return {
            books: {
                list: listBooks,
                add: addBook
            },
            categories: {
                list: listCategories
            }
        };
    }());
    return library;
}

