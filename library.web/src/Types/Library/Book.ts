import IAuthorData from "./author";
import IGenreData from "./genre";

export default interface IBookData {
    id?: any | null,
    name: string,
    year: string,
    authors: Array<IAuthorData>,
    genres: Array<IGenreData>,
    createDate: bigint,
    editDate: bigint
}
