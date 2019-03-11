import {Entity, model, property} from '@loopback/repository';

@model()
export class Projects extends Entity {
  @property({
    type: 'number',
    id: true,
  })
  number?: number;

  @property({
    type: 'string',
    required: true,
  })
  name: string;

  @property({
    type: 'string',
  })
  location?: string;

  @property()
  departmentId: number;

  constructor(data?: Partial<Projects>) {
    super(data);
  }
}
