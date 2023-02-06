import axios from "axios";
import http from "../../http-common";
import IBookData from "../../types/library/book";
import IAddBookData from "../../types/library/addBook";
import IEditBookData from "../../types/library/editBook";
import IAuthorData from "../../types/library/author";
import IGenreData from "../../types/library/genre";

class LibraryService {
    getAllAuthors() {
        return http.get<Array<IAuthorData>>("/library/authors");
    }

    getAllGenres() {
        return http.get<Array<IGenreData>>("/library/genres");
    }

    getAllBooks() {
        return http.get<Array<IBookData>>("/library/books");
    }

    getBook(id : any){
        return http.get<IBookData>(`/library/books/${id}`);
    }

    addBook(data: IAddBookData){
        return http.post<any>("/library", data)
    }

    editBook(data: IEditBookData){
        return http.put<any>("/library", data)
    }

    deleteBook(id : any){
        return http.delete<any>(`/library/${id}`)
    }
}

export default new LibraryService();