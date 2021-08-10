import {Component, OnInit} from '@angular/core';
import {Observable, of} from 'rxjs';

export interface Student {
  id: number,
  name: string,
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
        marks: [10, 11, 8, 10]
      },{
        id: 2,
        name: 'Lena',
        marks: [11, 12, 10, 11]
      },{
        id: 3,
        name: 'Sasha',
        marks: [8, 9, 10, 4]
      },
    ]
  }
}
