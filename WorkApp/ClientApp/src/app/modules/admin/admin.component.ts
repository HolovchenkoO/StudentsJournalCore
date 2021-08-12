import {Component, OnInit} from '@angular/core';
import {Observable, of} from 'rxjs';

export interface Student {
  id: number,
  name: string,
  age: number,
  groupe: string,
  course: string,
  marks: number[]
}

@Component({
  selector: 'admin',
  templateUrl: './admin.component.html',
  styleUrls: ['./admin.component.css']
})
export class AdminComponent implements OnInit{
  title = 'app';

  //TODO: insert after testing
  // students$: Observable<Student[]> = of([]);

  displayedColumns: string[] = ['id', 'name'];
  students: Student[] = [];
  clickedRow: Student;

  ngOnInit(): void {
    this.students = [
      {
        id: 1,
        name: 'Alex',
        age: 23,
        groupe: 'SPD93',
        course: '3',
        marks: [10, 11, 8, 10]
      },{
        id: 2,
        name: 'Lena',
        age: 21,
        groupe: 'SPD92',
        course: '2',
        marks: [11, 12, 10, 11]
      },{
        id: 3,
        name: 'Sasha',
        age: 19,
        groupe: 'SPD91',
        course: '1',
        marks: [8, 9, 10, 4]
      },
    ]
  }
}
