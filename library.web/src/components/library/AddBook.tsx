import React, {useState, ChangeEvent, useEffect} from 'react';
import LibraryService from "../../services/library/library.service"
import IAddBookData from '../../types/library/addBook';
import IAuthorData from '../../types/library/author';
import IGenreData from '../../types/library/genre';


const AddBook: React.FC = () => {
    const initialBookState : IAddBookData = {
        name: "",
        year: "",
        authors: [{id: "", name: ""}],
        genres: [{id: "", name: ""}],
    };

    const [book, setBook] = useState(initialBookState);
    const [authors, setAuthors] = useState<Array<IAuthorData>>([])
    const [genres, setGenres] = useState<Array<IGenreData>>([])
    const [submitted, setSubmitted] = useState<boolean>(false);

    useEffect(() => {
        retrieveAuthors();
        retrieveGenres();
    }, []);

    function retrieveAuthors() {
        LibraryService.getAllAuthors()
            .then((response: any) => {
                setAuthors(response.data);
                console.log(response.data);
            })
            .catch((e: Error) => {
                console.log(e);
            });
    }

    function retrieveGenres() {
        LibraryService.getAllGenres()
            .then((response: any) => {
                setGenres(response.data);
                console.log(response.data);
            })
            .catch((e: Error) => {
                console.log(e);
            });
    }

    const handleInputChange = (event: ChangeEvent<HTMLInputElement>) => {
        const { name, value } = event.target;
        setBook({ ...book, [name]: value });
    };

    const saveBook = () => {
        let data = {
            name: book.name,
            year: book.year,
            authors: book.authors,
            genres: book.genres,
        };

        LibraryService.addBook(data)
            .then((response: any) => {
                //TODO : push notify

                setSubmitted(true);
                console.log(response.data);
            })
            .catch((e: Error) => {
                console.log(e);
            });
    };

    const newBook = () => {
        setBook(initialBookState);
        setSubmitted(false);
    };

    return (
        <div className="submit-form">
            {submitted ? (
                <div>
                    <h4>You submitted successfully!</h4>
                    <button className="btn btn-success" onClick={newBook}>
                        Add
                    </button>
                </div>
            ) : (
                <div>
                    <div className="form-group">
                        <label htmlFor="title">Title</label>
                        <input
                            type="text"
                            className="form-control"
                            id="title"
                            required
                            value={book.name}
                            onChange={handleInputChange}
                            name="name"
                        />
                    </div>

                    <div className="form-group">
                        <label htmlFor="description">Year</label>
                        <input
                            type="number"
                            className="form-control"
                            id="description"
                            required
                            value={book.year}
                            onChange={handleInputChange}
                            name="year"
                        />
                    </div>

                    <button onClick={saveBook} className="btn btn-success">
                        Submit
                    </button>
                </div>
            )}
        </div>
    );
};

export default AddBook;