export class UserTile {
    id: number;
    firstName: string;
    middleName: string ;
    lastName: string;
    author: string;
    articleType: string;
    registrationDate: string;
    editingAssignments: number;
    reviewAssignments: number;
    submission: number;

    GetChildData(data) {
        console.log(data);
    }
}
