export interface Pagination {
    currentPage: number;
    itermsPerPage: number;
    totalsItems: number;
    totalPages: number;
}

export class PaginatedResult<T> {
    result: T;
    pagination: Pagination;
}