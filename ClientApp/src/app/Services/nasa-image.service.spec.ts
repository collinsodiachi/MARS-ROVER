import { TestBed } from '@angular/core/testing';

import { NasaImageService } from './nasa-image.service';

describe('NasaImageService', () => {
  beforeEach(() => TestBed.configureTestingModule({}));

  it('should be created', () => {
    const service: NasaImageService = TestBed.get(NasaImageService);
    expect(service).toBeTruthy();
  });
});
