import { OpenShiftTemplatePage } from './app.po';

describe('OpenShift App', function() {
  let page: OpenShiftTemplatePage;

  beforeEach(() => {
    page = new OpenShiftTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
