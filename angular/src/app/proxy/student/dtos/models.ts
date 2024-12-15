import type { Grade } from '../../enum/grade.enum';
import type { EntityDto } from '@abp/ng.core';

export interface CreateUpdateStudentDto {
  name: string;
  age: number;
  grade: Grade;
}

export interface StatisticsDto {
  totalStudents: number;
  averageAge: number;
  gradeDistribution: Record<string, number>;
}

export interface StudentDto extends EntityDto<string> {
  name: string;
  age: number;
  grade?: string;
}
