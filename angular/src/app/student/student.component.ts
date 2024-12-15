import { StudentService } from './../proxy/student/student.service';
import { PagedResultDto, ListService } from '@abp/ng.core';
import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { StudentDto } from '@proxy/student/dtos';
import { ConfirmationService, Confirmation } from '@abp/ng.theme.shared';
import { Grade, gradeOptions } from '@proxy/enum';
@Component({
  selector: 'app-student',
  templateUrl: './student.component.html',
  styleUrl: './student.component.scss',
  providers: [ListService],
})
export class StudentComponent implements OnInit {
  Student = { items: [], totalCount: 0 } as PagedResultDto<StudentDto>;

  form: FormGroup; // add this line

  // add StudentTypes as a list of StudentType enum members
  Studentgrades = gradeOptions;

  isModalOpen = false;
  selectedstudent: any;
  rows = [];
  temp = [];
  filteredRows = [];
  constructor(
    public readonly list: ListService,
    private StudentService: StudentService,
    private fb: FormBuilder,
    private confirmation: ConfirmationService
  ) { }
fc(){
  return this.form.controls;
}
  // Add a delete method
  delete(id: string) {
    this.confirmation.warn('::AreYouSureToDelete', '::AreYouSure').subscribe((status) => {
      if (status === Confirmation.Status.confirm) {
        this.StudentService.delete(id).subscribe(() => this.list.get());
      }
    });
  }

  ngOnInit() {
    const StudentStreamCreator = (query) => this.StudentService.getList(query);

    this.list.hookToQuery(StudentStreamCreator).subscribe((response) => {
      this.Student = response;
      this.Student = response;
      this.rows = response.items;
      this.temp = [...response.items];
      this.filteredRows = [...response.items];
    });
  }
  updateFilter(event: any) {
    debugger;
    const val = event.target.value.toLowerCase();
    const temp = this.temp.filter((d: any) => {
      return d.name.toLowerCase().indexOf(val) !== -1 || !val;
    });
    this.filteredRows = temp;
  }
  createStudent() {
    this.buildForm(); // add this line
    this.isModalOpen = true;
  }
  // Add editstudent method
  editstudent(id: string) {
    this.StudentService.get(id).subscribe((student) => {
      this.selectedstudent = student;
      this.buildForm();
      this.isModalOpen = true;
    });
  }
  // add buildForm method
  buildForm() {
    this.form = this.fb.group({
      name: [this.selectedstudent?.name, Validators.required],
      age: [this.selectedstudent?.age,[Validators.required,Validators.min(5),Validators.max(18)]],
      grade: [this.selectedstudent?.grade, Validators.required],
    });
  }

  // change the save method
  save() {
    if (this.form.invalid) {
      return;
    }

    const request = this.selectedstudent?.id
      ? this.StudentService.update(this.selectedstudent?.id, this.form.value)
      : this.StudentService.create(this.form.value);

    request.subscribe(() => {
      this.isModalOpen = false;
      this.form.reset();
      this.list.get();
    });
  }
}

